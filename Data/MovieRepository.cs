using System.Collections.Generic;
using System.Linq;
using AppForMovie.Models;

namespace AppForMovie.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies=null;
        
        static MovieRepository(){
            _movies=new List<Movie>(){
                new Movie(){ 
                    Id=1,
                    Name="Jarhead",
                    ShortDescription=" <p> Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint praesentium, expedita cumque rerum dignissimos accusamus tempora unde hic deleniti est. Id amet nesciunt perspiciatis officia molestias, eveniet quibusdam! Facere, animi.</p>",
                    Description="Suriye hava sahasında vurularak uçağı düşürülen başarılı pilot Binbaşı Ronan Jackson, mucizevi bir şekilde hayatta kalmayı başarır. Hayatta kaldığı fark edildikten sonra Hizbullah militanları tarafından esir alınan Binbaşı, sert savaşın içerisinde oldukça güçlü bir yaşam mücadelesi hikayesine sahip olacaktır.", 
                    ImageUrl="1.jpg"
                    },
                 new Movie(){
                      Id=2,
                      Name="Spycies",
                       ShortDescription=" <p> Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint praesentium, expedita cumque rerum dignissimos accusamus tempora unde hic deleniti est. Id amet nesciunt perspiciatis officia molestias, eveniet quibusdam! Facere, animi.</p>",
                      Description="Çalınan değerli bir eşyanın peşine düşen iki ajanın hikayesinin anlatıldığı filmde, eşyanın çalındığı haberini alan Vladimir ve Hector olayı soruşturmaya başlar. Çalınan değerli eşyayı bulmak için maceradan maceraya atılacaklar, kendilerini hiç beklemedikleri bir maceranın içinde bulacaklardır.", 
                      ImageUrl="2.jpg"},
                  new Movie(){ 
                      Id=3,
                      Name="The Lead",
                       ShortDescription="  <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint praesentium, expedita cumque rerum dignissimos accusamus tempora unde hic deleniti est. Id amet nesciunt perspiciatis officia molestias, eveniet quibusdam! Facere, animi.</p>",
                      Description="Büyük ve skandal hikayelerin peşine düşerek ünlü ve tanınmış bir muhabir olmak isteyen Sasha Bruder kaçırılır. Kaçırıldıktan sonra oldukça sıradışı bir hikayede kahraman olduğunu çok geçmeden öğrenecektir.", 
                      ImageUrl="3.jpg"},
                   new Movie(){ 
                       Id=4,
                       Name="Truth and Justice",
                        ShortDescription=" <p> Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint praesentium, expedita cumque rerum dignissimos accusamus tempora unde hic deleniti est. Id amet nesciunt perspiciatis officia molestias, eveniet quibusdam! Facere, animi.</p>",
                       Description="Genç ve çalışkan Andres ve eşi, bir yerden borç para bularak çiftlik satın almaya karar verirler. Hayallerindeki hayatı kurmak için canla başla çabalayan çift, çok geçmeden doğanın acımasızlığına maruz kalacak, Andreas’ın tutuculuğu ise gerçeği görmesine engel olacaktır.",
                        ImageUrl="4.jpg"}
                      };
                       }     
        public static List<Movie>Movies{
            get {
                return _movies;
            }
        }  
        public static void AddMovie(Movie entity)  { //void ile geri dönüş değeri olmmayacak
            _movies.Add(entity);
        }  
        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i=>i.Id==id);
        }                                                              
    }
}