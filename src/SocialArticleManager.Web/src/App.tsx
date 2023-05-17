import "./App.css";
import { Route, Routes } from "react-router-dom";
import { Layout } from "./common/layout/layout";
import { ArticlePage } from "./pages/articles/article.page";

function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route path="/" element={<ArticlePage />} />
        </Route>
      </Routes>
    </>
  );
}

export default App;
