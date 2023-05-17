import React from "react";
import { Article } from "../../models/article";
import { ArticlesList } from "./components/articles.list";

export const ArticlePage = () => {
  const data: Article[] = [
    {
      title: "Aumento de Alunos",
      content:
        "Houve um aumento de alunos por 30% . O CEO da faculdade referiu que isto é devido ao facto que os preços tornaram-se mais competitivos e mais aliciantes",
      author: {
        name: "UAL",
      },
    },
  ];
  return (
    <>
      <div className="row mt-3 d-flex justify-content-center">
        <div className="col col-sm-4">
          <ArticlesList articles={data} />
        </div>
      </div>
    </>
  );
};
