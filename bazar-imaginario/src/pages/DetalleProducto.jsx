import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { useNavigate } from "react-router-dom";
import IconoBazar from "../assets/iconBazar.png";
import "bootstrap/dist/css/bootstrap.min.css";

const Star = ({ filled }) => (
  <span style={{ color: filled ? "gold" : "lightgray" }}>&#9733;</span>
);

const DetalleProducto = () => {
  const navigate = useNavigate();
  const { id } = useParams();
  const [producto, setProducto] = useState([]);

  useEffect(() => {
    const detalleProducto = async () => {
      try {
        // Realiza la petición a la API
        const api = await fetch(`http://localhost:48882/api/values/${id}`);

        // Verifica si la respuesta es exitosa (código 200)
        if (!api.ok) {
          throw new Error(`Error al obtener datos: ${api.status}`);
        }

        // Recupera los productos
        const productosApi = await api.json();
        console.log(productosApi);

        // Asignamos la cadena con los datos al state
        setProducto(productosApi);
      } catch (error) {
        console.error("Error al obtener datos de la API:", error.message);
        // Manejar el error según tus necesidades
      }
    };
    detalleProducto();
  }, []);

  const paginaAnterior = () => {
    navigate(-1); // Navegará a la página anterior
  };

  return (
    <>
      <div className="container">
        <br />
        <br />
        <br />
        <div className="row">
          {producto && Array.isArray(producto.images) && producto.images[0] && (
            <div className="col-4">
              <img src={producto.images[0]} alt="" />
            </div>
          )}
          {producto && Array.isArray(producto.images) && producto.images[1] && (
            <div className="col-4">
              <img src={producto.images[2]} alt="" />
            </div>
          )}
          {producto && Array.isArray(producto.images) && producto.images[2] && (
            <div className="col-4">
              <img src={producto.images[3]} alt="" />
            </div>
          )}
        </div>

        <h2 className="titulo" style={{ color: "white" }}>
          {" "}
          {producto.title}{" "}
        </h2>
        <p
          style={{ color: "white", textAlign: "justify" }}
          className="justify-content-center"
        >
          {producto.description}
        </p>
        <div className="row">
          <div className="col-6">
            <p className="price" style={{ color: "green" }}>
              ${producto.price}
            </p>
          </div>
          <div className="col-6">
            <div className="rating">
              <Star filled={producto.rating >= 1} />
              <Star filled={producto.rating >= 2} />
              <Star filled={producto.rating >= 3} />
              <Star filled={producto.rating >= 4} />
              <Star filled={producto.rating >= 5} />
            </div>
          </div>
        </div>
        <p
          className="category"
          style={{ color: "aqua", textAlign: "center", marginLeft: "5px" }}
        >
          {producto.category}
        </p>
        <br />
        <br />
        <br />
        <br />
        <button className="neon-button" onClick={paginaAnterior}>
          <img
            src="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.0/icons/arrow-left.svg"
            alt="Icono de regresar"
          />
          Regresar
        </button>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
      </div>
    </>
  );
};

export default DetalleProducto;
