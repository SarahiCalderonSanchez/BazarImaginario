import React from "react";
import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import Busqueda from "./pages/Busqueda";
import ListaProducts from "./pages/ListaProducts";
import DetalleProducto from "./pages/DetalleProducto";

const App = () => {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Busqueda />} />
          <Route path="/listaProducts/:palabra" element={<ListaProducts />} />
          <Route path="/detalleProducto/:id" element={<DetalleProducto />} />
        </Routes>
      </BrowserRouter>
    </>
  );
};

export default App;
