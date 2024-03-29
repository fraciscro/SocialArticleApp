import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

export const Navbar = () => {
  const [term, setTerm] = useState<string>("");
  const navigate = useNavigate();
  function searchTerm(event: any) {
    event.preventDefault();
    navigate(`search?term=${term}`);
  }
  return (
    <>
      <nav className="navbar navbar-expand-lg navbar-white bg-white shadow-sm">
        <div className="container">
          <Link className="navbar-brand" to="/">
            Social Article
          </Link>
          <button
            className="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon"></span>
          </button>
          <div className="collapse navbar-collapse" id="navbarSupportedContent">
            <ul className="nav navbar-nav mx-auto">
              <li className="nav-item">
                <form onSubmit={searchTerm}>
                  <input
                    value={term}
                    id="term"
                    onChange={(event) => setTerm(event.target.value)}
                    name="term"
                    className="form-control me-2 rounded-4"
                    type="search"
                    placeholder="Search"
                    aria-label="Search"
                  />
                </form>
              </li>
            </ul>
            <ul className="nav navbar-nav">
              <li className="nav-item">
                <a className="nav-link" href="#">
                  Home
                </a>
              </li>
              <li className="nav-item">
                <a className="nav-link" href="#">
                  Help
                </a>
              </li>
              <li className="nav-item dropdown">
                <button
                  className="btn btn-default"
                  id="dropdownMenuButton1"
                  data-bs-toggle="dropdown"
                  aria-expanded="false"
                >
                  <i className="fa-regular fa-user"></i>
                </button>
                <ul
                  className="dropdown-menu "
                  aria-labelledby="dropdownMenuButton1"
                >
                  <li>
                    <a className="dropdown-item" href="#">
                      Profile
                    </a>
                  </li>
                  <li>
                    <a className="dropdown-item" href="#">
                      Logout
                    </a>
                  </li>
                </ul>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </>
  );
};
