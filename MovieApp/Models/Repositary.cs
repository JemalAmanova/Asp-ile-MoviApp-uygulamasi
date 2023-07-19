using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Repositary
    {
        private static readonly List<Movie> _movies=new();
        
        static Repositary(){
            _movies=new List<Movie>(){
                new Movie() {Id=1, Name="The Pursuit Of Happyness", Description="The Pursuit of Happyness by Chris Gardner tells the story of a struggling salesman who never gave up trying to find true happiness for himself and his son. He faced many challenges in his life but overcame adversity to succeed above all odds.", Image="1.jpg", Imdb=9},
               new Movie() {Id=2, Name="The Imitation Game: Enigma ", Description="During World War II, the English mathematical genius Alan Turing tries to crack the German Enigma code with help from fellow mathematicians while attempting to come to terms with his troubled private life.", Image="2.jpg", Imdb=9},
               new Movie() {Id=3, Name="The Intern", Description="The plot follows a 70-year-old widower who becomes a senior intern at a fashion website, where he forms an unlikely friendship with the company's workaholic CEO", Image="3.jpg", Imdb=7},
               new Movie() {Id=4, Name="Amélie", Description="Amélie is a fanciful comedy about a young woman who discretely orchestrates the lives of the people around her, creating a world exclusively of her own making.", Image="4.jpg", Imdb=8}
               };
        }
         public static List<Movie> Movies{
            get{
                return _movies;
            }

         }
         public static Movie? GetById(int id){
            return _movies.FirstOrDefault(c=>c.Id==id);
         }
    }
}