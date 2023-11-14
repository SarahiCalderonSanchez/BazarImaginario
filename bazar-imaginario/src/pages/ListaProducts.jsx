import React, { useEffect, useState } from "react";
import IconoBazar from "../assets/iconBazar.png";
import "../styles/ListaProducts.css";
import "bootstrap/dist/css/bootstrap.min.css";
import { useParams } from "react-router-dom";
import { useNavigate } from "react-router-dom";

// Componente de Estrella
const Star = ({ filled }) => (
  <span style={{ color: filled ? "gold" : "lightgray" }}>&#9733;</span>
);

const useProductos = () => {
  const [productos, setProductos] = useState([]);
  const { palabra } = useParams();
  const [filtroInput, setFiltroInput] = useState("");

  useEffect(() => {
    const regApiProductos = async () => {
      try {
        // Realiza la petición a la API
        const api = await fetch("http://localhost:48882/api/values");

        // Verifica si la respuesta es exitosa (código 200)
        if (!api.ok) {
          throw new Error(`Error al obtener datos: ${api.status}`);
        }

        // Recupera los productos
        const productosApi = await api.json();

        // Asignamos la cadena con los datos al state
        setProductos(productosApi);
      } catch (error) {
        console.error("Error al obtener datos de la API:", error.message);
      }
    };
    regApiProductos();
  }, []);

  let filterProductos = productos.filter((producto) => {
    return producto.title.toUpperCase().includes((palabra || "").toUpperCase());
  });

  if (filtroInput) {
    filterProductos = productos.filter((producto) => {
      return producto.title.toUpperCase().includes(filtroInput.toUpperCase());
    });
  }

  const inputBuscar = (e) => {
    console.log(e.target.value);
    setFiltroInput(e.target.value); // Actualizamos el valor del input
  };

  return {
    productos,
    palabra,
    inputBuscar,
    filterProductos,
  };
};

const ListaProducts = () => {
  const { inputBuscar, productos, palabra, filterProductos } = useProductos();
  const [selectedProductId, setSelectedProductId] = useState(null);
  const navigate = useNavigate();
  const [palabraProducto, setPalabraProducto] = useState("");

  const handleProductSelection = (productId) => {
    setSelectedProductId(productId);
    navigate(`/detalleProducto/${productId}`);
  };

  useEffect(() => {
    console.log("Palabra recuperada:", palabra);
  }, [palabra]);

  return (
    <>
      <div className="container">
        <div className="row align-items-center">
          <div className="col-2">
            <div className="logo">
              <img
                src={IconoBazar}
                alt="Icono del Bazar"
                className="logo-img"
              />
            </div>
          </div>
          <div className="col-8">
            <div className="input-group">
              <input
                type="text"
                className="form-control"
                placeholder="Buscar productos"
                aria-label="Buscar productos"
                aria-describedby="basic-addon2"
                onChange={inputBuscar}
              />
            </div>
          </div>
          {filterProductos.length > 0 ? (
            <ul className="product-list">
              {filterProductos.map((producto, index) => (
                <li
                  className={`product-item ${
                    selectedProductId === producto.id ? "selected" : ""
                  }`}
                  key={producto.id}
                  onClick={() => handleProductSelection(producto.id)}
                >
                  <div className="row">
                    <div className="col-3">
                      <div className="images">
                        {producto.images.length > 0 && (
                          <img
                            src={producto.images[2]}
                            alt={`Product ${index + 1}`}
                            className="img-fluid rounded-image"
                          />
                        )}
                      </div>
                    </div>
                    <div className="col-8">
                      <div className="product-info">
                        <h2 className="title">{producto.title}</h2>
                        <p className="category">{producto.category}</p>
                        <p className="description">{producto.description}</p>
                        <div className="row contenido">
                          <div className="col-6">
                            <p className="price">$ {producto.price}</p>
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
                      </div>
                    </div>
                  </div>
                </li>
              ))}
            </ul>
          ) : (
            <p>No se encontraron productos</p>
          )}
        </div>
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
    </>
  );
};

export default ListaProducts;
