import React from 'react'
import { Article } from '../../models/article'
import { ArticlesList } from './components/articles.list'

export const ArticlePage = () => {
    const data: Article []=[
        {
            name: 'Article 1',
            title: 'Article 1',
            content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam, voluptatum.',
            author:{
                name: 'Author 1',
            }
        }

    ]
  return (
    <>
    <div className="row mt-3 d-flex justify-content-center">
        <div className="col col-sm-4">
        <ArticlesList articles={data}/>
        </div>
    </div>
    
       
    </>
  )
}
