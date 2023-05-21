import "./App.css";
import { Route, Routes } from "react-router-dom";
import { Layout } from "./common/layout/layout";
import { ArticlePage } from "./pages/article/article.page";
import { OrganizationPage } from "./pages/organization/organization.page";
import { SearchPage } from "./pages/search/search.page";
import { LoginPage } from "./pages/auth/login.page";
import { RegisterPage } from "./pages/auth/register.page";
import { WelcomePage } from "./pages/welcome/welcome.page";

function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route path="/" element={<ArticlePage />} />
          <Route path="/organizations/:id" element={<OrganizationPage />} />
          <Route path="/login" element={<LoginPage />} />
          <Route path="/register" element={<RegisterPage />} />
          <Route path="/search" element={<SearchPage />} />
          <Route path="/welcome" element={<WelcomePage />} />
        </Route>
      </Routes>
    </>
  );
}

export default App;
