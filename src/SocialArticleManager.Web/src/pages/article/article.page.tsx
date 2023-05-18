import React from "react";
import { Article } from "../../models/article";
import { ArticlesList } from "./components/articles.list";

export const ArticlePage = () => {
  const data: Article[] = [
    {
      image_url:
        "https://scontent.flis11-2.fna.fbcdn.net/v/t1.18169-9/15442208_10154300722142637_5466607496147225214_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=19026a&_nc_eui2=AeFQ4SlO_YH42KHrM9WB9KiehhjAC0gb-iKGGMALSBv6IkLDKNAH6z97g5U8EXRBizFa1yD0uC_H-IevYI2fWXB6&_nc_ohc=CtzsxAaRa3cAX8n99Ik&_nc_ht=scontent.flis11-2.fna&oh=00_AfCidnWi5_pqMnZMQycYPBBKkHa71sCkLWGsMpZ0HMCB8w&oe=648D7BB3",
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
