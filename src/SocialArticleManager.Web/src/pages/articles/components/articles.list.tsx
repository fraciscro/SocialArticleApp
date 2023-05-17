import React from "react";
import { Article } from "../../../models/article";
import { Link } from "react-router-dom";

export const ArticlesList = ({ articles }: any) => {
  return (
    <>
      {articles.map((article: Article, index: any) => (
        <div className="row" key={index}>
          <div className="col">
            <div className="card rounded-2 shadow">
              <div className="card-body">
                <h5 className="card-title">
                  <div className="row">
                    <div className="col col-2">imagem</div>
                    <div className="col">
                      <b>
                        <Link to={"organizations/" + article.author.name}>
                          {article.author.name}
                        </Link>
                      </b>
                    </div>
                  </div>
                </h5>
                <div className="row mt-2">
                  <div className="col">{article.content}</div>
                </div>
                <div className="row mt-2">
                  <div className="col-2">
                    <button className="btn btn-default">
                      <i className="fa-sharp fa-solid fa-heart"></i>
                    </button>
                  </div>
                  <div className="col-2">
                    <button className="btn btn-default">
                      <i className="fa-solid fa-comment"></i>
                    </button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      ))}
    </>
  );
};
