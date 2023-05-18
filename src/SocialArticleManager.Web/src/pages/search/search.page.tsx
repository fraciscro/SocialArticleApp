import React from "react";
import { useSearchParams } from "react-router-dom";
import Tab from "react-bootstrap/Tab";
import Tabs from "react-bootstrap/Tabs";
import { Article } from "../../models/article";
import { ArticlesList } from "../article/components/articles.list";
export const SearchPage = () => {
  const [searchParams] = useSearchParams();
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
      <div className="row d-flex justify-content-center mt-5">
        <div className="col col-sm-6">
          <div className="card  ">
            <Tabs id="uncontrolled-tab-example" className="mb-3" fill>
              <Tab eventKey="home" title="Articles">
                <div className="row mt-3">
                  <div className="col">
                    <ArticlesList articles={data} />
                  </div>
                </div>
              </Tab>
              <Tab eventKey="profile" title="Organizations"></Tab>
              <Tab eventKey="contact" title="Users"></Tab>
            </Tabs>
          </div>
        </div>
      </div>
    </>
  );
};
