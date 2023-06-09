//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace car_manufacturer.app_database
{
    using System;
    using System.Collections.Generic;
    
    public partial class products
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string manufacturer { get; set; }
        public string supplier { get; set; }
        public string description { get; set; }
        public Nullable<double> count { get; set; }
        public Nullable<double> price { get; set; }
        public string MaterialPicture
        {
            get
            {
                if (String.IsNullOrEmpty(image) || string.IsNullOrWhiteSpace(image))
                {
                    return "/image/picure.jpg";
                }
                else
                {
                    return "/image/" + image;
                }
            }
            set
            {

            }
        }
    }

}
