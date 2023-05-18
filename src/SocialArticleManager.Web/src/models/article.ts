export interface Article {
  image_url: string;
  title: string;
  content: string;
  author: Author;
}

export interface Author {
  name: string;
}
