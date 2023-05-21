import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { auth } from "../../config/firebase";
import { signOut } from "firebase/auth";

export const Navbar = () => {
  const [term, setTerm] = useState<string>("");
  const navigate = useNavigate();
  function searchTerm(event: any) {
    event.preventDefault();
    navigate(`search?term=${term}`);
  }

  const signOutWithGoogle = async () => {
    const result = await signOut(auth);
    console.log(result);
    navigate("/");
  };

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
                  {auth.currentUser ? (
                    <img
                      src={
                        auth.currentUser?.photoURL ||
                        "https://cdn.pixabay.com/photo/2016/03/31/19/56/avatar-1295397__340.png"
                      }
                      className="img-fluid profile-image-pic img-thumbnail rounded-circle"
                      width="30px"
                      alt="profile"
                    />
                  ) : (
                    <i className="fa-regular fa-user"></i>
                  )}
                </button>
                <ul
                  className="dropdown-menu "
                  aria-labelledby="dropdownMenuButton1"
                >
                  {auth.currentUser ? (
                    <li>
                      <button
                        className="dropdown-item"
                        onClick={signOutWithGoogle}
                      >
                        Log out
                      </button>
                    </li>
                  ) : (
                    <li>
                      <Link className="dropdown-item" to="/login">
                        Login
                      </Link>
                    </li>
                  )}
                </ul>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </>
  );
};
