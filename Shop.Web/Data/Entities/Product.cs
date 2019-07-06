﻿namespace Shop.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    //esta clase se convertira mas adelante en base de datos
    public class Product
    {
        public int Id { get; set; }//este atributo sera autoincrementable en la bd

        /*hay anotaciones que solo sirven para cambiar la forma en que se va a visualizar este campo_
         pero hay anotaciones que cambian la estructura del campo como por ejemplo el tamaño del mismo*/
        [MaxLength(50,ErrorMessage = "The field {0} only contain {1} characters length.")]//50 caracteres maximo,personalizamos el error que desplegara
        [Required]//si queremos que el campo sea obligatorio o sea diferente a null
        public string Name { get; set; }//nombre del producto

        /*a esto se le conoce como decoradores y no es mas que formatear en la base de datos
         la forma en que se va a ver el campo Price donde "{0:C2}" donde la moneda tendra un
         formato de currency 2 y ademas de eso tendra la moneda configurada en la pc o sea
         aparecera la separacion de miles por una coma y con dos decimales.*/
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }//precio del producto formateado para mostrarlo como moneda

        [Display(Name = "Image")]//asi se desplegara el atributo ImageUrl
        public string ImageUrl { get; set; }//aqui ira la ruta de la imagen

        [Display(Name = "Last Purchase")]//asi se desplegara el atributo LastPurchase
        /*aqui lo contrario de que un campo sea obligatorio tambien lo podemos convertir a lo contrario_
         que no sea obligatorio se utiliza un truco exclusivo de c# esto no tiene nada que ver con el_
         entitie framework se coloca el signo ? delante del campo para decirle que el campo permite null*/
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]//asi se desplegara el atributo LastSale
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Availabe?")]//asi se desplegara el atributo IsAvailabe
        public bool IsAvailabe { get; set; }

        /*aqui se mostrar solo el numero con la coma de miles y para editar el campo solo double
         por eso ApplyFormatInEditMode es igual a false solo mostrara los numeros sin coma*/
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        /*NOTA==> para que los cambios se reflejen en la BD debemos de ir a Tools-NuGet Package Manager-_
         Pacakage Manager Console, verificamos que estemos en el proyecto correcto y agregamos una_
         nueva migracion: add-migration ModifyProducts*/
    }

  
}
