using Azure;
using Azure.Search.Documents;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Indexes.Models;
using Azure.Search.Documents.Models;
using SocialArticleManager.Api.Application.Articles.Models;
using SocialArticleManager.Api.Application.Common.Interfaces;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;

namespace SocialArticleManager.Api.Infrastructure.ElasticSearch.Article
{
    public class ArticleElasticSearch : IArticleElasticSearch
    {
        private readonly SearchIndexClient _searchIndexClient;
        private readonly SearchClient _searchClient;
        public ArticleElasticSearch(SearchIndexClient searchIndexClient)
        {
            _searchIndexClient = searchIndexClient;
            _searchClient = new SearchClient(new Uri("https://social-article-manager-search.search.windows.net"), "article", new AzureKeyCredential("YaUqbhZbsrF5CBszq8cKMkwGpiIqedMVKmxXdFoCB1AzSeB1MKD1"));
        }
        public async Task AddArticle(ArticleModel article)
        {
            await CheckIfIndexExists();
            var articleToAdd = new ArticleSearchModel(article.Id, article.Title, article.Content, article.Author.Name);
            IndexDocumentsAction<ArticleSearchModel> indexAction = IndexDocumentsAction.Upload(articleToAdd);

            IndexDocumentsBatch<ArticleSearchModel> batch = new IndexDocumentsBatch<ArticleSearchModel>();
            batch.Actions.Add(indexAction);
            await _searchClient.IndexDocumentsAsync(batch);
        }
        private async Task CheckIfIndexExists()
        {
            try
            {
                Response<SearchIndex> indexResponse = await _searchIndexClient.GetIndexAsync("article");
            }
            catch (Exception)
            {
                var fieldBuilder = new FieldBuilder();
                var searchFields = fieldBuilder.Build(typeof(ArticleSearchModel));

                var definition = new SearchIndex("article", searchFields);

                var suggester = new SearchSuggester("sg", new[] { "Title","Content" ,"Author"});
                definition.Suggesters.Add(suggester);

                await _searchIndexClient.CreateIndexAsync(definition);
            }


        }
        public async Task<List<ArticleModel>> SearchArticleByTerm(string term)
        {
            var searchOptions = new SearchOptions
            {
                QueryType = SearchQueryType.Full
            };
            searchOptions.SearchFields.Add("Title");
            searchOptions.SearchFields.Add("Content");
            searchOptions.SearchFields.Add("Author");
            var searchText = $"{term}*";
            var searchResults = await _searchClient.SearchAsync<ArticleSearchModel>(searchText, searchOptions);
            var articles = searchResults.Value.GetResults().Select(d => d.Document).ToList();
            var articlesResult= articles.ConvertAll(a=> new ArticleModel(a.Id,a.Title,a.Content,new Author(a.Author)));
            // Iterate over the search results and do something with each Post object
            return articlesResult;
        }
    }
}
