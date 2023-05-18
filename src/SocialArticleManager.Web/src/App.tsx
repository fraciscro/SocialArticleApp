import "./App.css";
import { Route, Routes } from "react-router-dom";
import { Layout } from "./common/layout/layout";
import { ArticlePage } from "./pages/article/article.page";
import { OrganizationPage } from "./pages/organization/organization.page";

function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route path="/" element={<ArticlePage />} />
          <Route path="/organizations/:id" element={<OrganizationPage />} />
        </Route>
      </Routes>
    </>
  );
}

export default App;
