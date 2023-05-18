using Azure.Search.Documents.Indexes;

namespace SocialArticleManager.Api.Infrastructure.ElasticSearch.Article
{
    public class ArticleSearchModel
    {
        [SimpleField(IsKey = true, IsFilterable = true)]
        public string Id { get; private set; }
        [SearchableField(IsSortable = true, IsFilterable = true, IsFacetable = true)]
        public string Title { get; private set; }
        [SearchableField(IsSortable = true, IsFilterable = true, IsFacetable = true)]
        public string Content { get; private set; }
        [SearchableField(IsSortable = true, IsFilterable = true, IsFacetable = true)]
        public string Author { get; private set; }
        public ArticleSearchModel(string id, string title, string content, string author)
        {
            Id = id;
            Title = title;
            Content = content;
            Author = author;
        }
    }

}
