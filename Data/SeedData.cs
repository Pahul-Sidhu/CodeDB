using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommunityApp.Models;

namespace CommunityApp.Data{
    public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
    }
    public static List<City> GetCities() {
        List<City> Cities = new() {
            new City() {    // 1
                CityName="Vancouver",
                CityId= 1,
                Province="British Columbia",
                Population=200000,
                ProvinceCode = "BC"
            },
            new City() {    //2
                CityName="Kelowna",
                CityId= 2,
                Province="British Columbia",
                Population=20000,
                ProvinceCode = "BC"
            },
            new City() {    // 3
                CityName="Surrey",
                CityId= 3,
                Province="British Columbia",
                Population=2000000,
                ProvinceCode = "BC"
            },
            new City() {    // 4
                CityName="Edmonton",
                CityId= 4,
                Province="Alberta",
                Population=200000,
                ProvinceCode = "AB"
            },
            new City() {    // 5
                CityName="Calgary",
                CityId= 5,
                Province="Alberta",
                Population=325461,
                ProvinceCode = "AB"
            },
            new City() {    // 6
                CityName="Red Deer",
                CityId= 6,
                Province="Alberta",
                Population=35643,
                ProvinceCode = "AB"
            },
            new City() {    // 7
                CityName="Toronto",
                CityId= 7,
                Province="Ontario",
                Population=20000000,
                ProvinceCode = "ON"
            },
            new City() {    // 8
                CityName="Brampton",
                CityId= 8,
                Province="Ontario",
                Population=896709,
                ProvinceCode = "ON"
            },
             new City() {    // 8
                CityName="London",
                CityId= 9,
                Province="Ontario",
                Population=5447647,
                ProvinceCode = "ON"
            },
        };

        return Cities;
    }

    public static List<Province> GetProvinces() {
        List<Province> provinces = new() {
            new Province {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
                
            },
            new Province {
                ProvinceCode = "ON",
                ProvinceName = "Ontario",
                
            },
            new Province {
                ProvinceCode = "AB",
                ProvinceName = "Alberta",
                
            },
            
        };

        return provinces;
    }
}

}