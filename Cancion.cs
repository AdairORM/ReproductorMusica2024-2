﻿using System;

namespace ReproductorMusica2024_2
{
    internal class Cancion
    {
        #region Atributos
        private string titulo;
        private string artista;
        private string album;
        private int duracion;
        #endregion

        #region Propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Album { get => album; set => album = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        #endregion

        #region Constructor
        public Cancion(string titulo, string artista, string album, int duracion)
        {
            Titulo = titulo;
            Artista = artista;
            Album = album;
            Duracion = duracion;
        }
        #endregion


        
    }
}
