import React from 'react'
import { Article } from '../../../models/article';

  
export const ArticlesList = ({articles}: any ) => {
  return (
    <>
        {articles.map((article:Article,index:any) => (
            <div className='row' key={index}>
                <div className="col">
                    <div className="card rounded-2 shadow">
                        <div className="card-body">
                        {article.content}
                            </div>
                    </div>
                </div>
            </div>
        ))}
    </>
  )
}
