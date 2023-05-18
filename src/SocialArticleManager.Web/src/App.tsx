import "./App.css";
import { Route, Routes } from "react-router-dom";
import { Layout } from "./common/layout/layout";
import { ArticlePage } from "./pages/article/article.page";
import { OrganizationPage } from "./pages/organization/organization.page";
import { LoginPage } from "./pages/login/login.page";

function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Layout />}>
          {/* Outlet no layout vai gerar todos os filhos da propria div*/}
          <Route path="/" element={<ArticlePage />} />
          <Route path="/organizations/:id" element={<OrganizationPage />} />
          <Route path="/login" element={<LoginPage />} />
        </Route>
      </Routes>
    </>
  );
}

export default App;
