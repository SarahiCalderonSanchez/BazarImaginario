import { useCallback, useEffect, useState } from "react";
import IconoBazar from "../assets/iconBazar.png";
import "../styles/Busqueda.css";
import { useNavigate, Link, Outlet } from "react-router-dom";
import ListaProducts from "./ListaProducts";

const Busqueda = () => {
  const [palabraBuscar, setPalabraBuscar] = useState("");

  const navigate = useNavigate();

  const fPalabra = () => {
    <ListaProducts palabra={palabraBuscar} />;
    navigate(`/listaProducts/${palabraBuscar}`);
  };

  // Creamos el useEffect
  const inputPalabra = (e) => {
    setPalabraBuscar(e.target.value);
  };

  // Agregamos un useEffect
  useEffect(() => {}, [palabraBuscar]);

  return (
    <>
      <div className="container">
        <div className="logo-container">
          <img src={IconoBazar} alt="Icono del Bazar" className="logo" />
          <h1 style={{ color: "white", marginTop: "10px" }}>
            Bazar Imaginario
          </h1>
          <div className="input-group mb-3">
            <span className="input-group-text" id="search-icon">
              <img
                src="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.0/icons/search.svg"
                alt="Icono de búsqueda"
              />
            </span>
            <input
              type="text"
              className="form-control"
              placeholder="Buscar..."
              aria-label="Buscar"
              aria-describedby="search-icon"
              onChange={inputPalabra}
            />
          </div>
          <button className="neon-button accordion" onClick={fPalabra}>
            Buscar
          </button>
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
        </div>
      </div>
    </>
  );
};

export default Busqueda;
