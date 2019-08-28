﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Database
    {
        
        public List<Product> Products = new List<Product>();
        Product GreatestHits = new Product("Greatest Hits", "Vinyl", "The best of Sugar Ray on one album!!!", 35);
        Product Vinyl1 = new Product("Floored", "Vinyl", "Sugar Ray's hit release from 1997", 30);
        Product Vinyl2 = new Product("Lemonade and Brownies", "Vinyl", "Sugar Ray's release from 1995", 30);
        Product Vinyl3 = new Product("14:59", "Vinyl", "Sugar Ray's most popular release from 1999. That was a good year", 30);
        Product Dvd = new Product("Scooby Doo The Movie","DVD", "Sugar Ray makes a star apperance in this movie", 20);
        Product HairGel = new Product("Hair Gel", "Cosmetic Product", "Thick gel perfect for spiking hair. Recomended for frosted tips.", 3.5);
        Product Tshirt1 = new Product("T-Shirt", "Merchandise", "Collectable T-Shirt that will probably be worth and exponential amount in a decade.", 12);
        Product Tshirt2 = new Product("T-Shirt", "Merchandise", "A less desirable design of T-Shirt. Won't be worth anything in a few years", 12);
        
        public Database(List() p)
        {

        Products.Add(Vinyl1);
        }
    }
}