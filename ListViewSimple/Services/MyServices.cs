using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewSimple.Services
{
    class MyServices
    {
        public List<MyData> GetMyData()
        {
            List<MyData> myData = new List<MyData>
            {
                new MyData{ Name = "John", Description = "This is the picture of a man", Pic_Id = Resource.Drawable.Pic00 },
                new MyData { Name = "Mary", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic01 },
                new MyData { Name = "Peter", Description = "This is the picture of a man", Pic_Id = Resource.Drawable.Pic02 },
                new MyData { Name = "Nancy", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic03 },
                new MyData { Name = "James", Description = "This is the picture of a man", Pic_Id = Resource.Drawable.Pic04 },
                new MyData { Name = "Wanda", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic05 },
                new MyData { Name = "Laura", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic06 },
                new MyData { Name = "Anna", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic07 },
                new MyData { Name = "Beatrice", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic08 },
                new MyData { Name = "Ellen", Description = "This is the picture of a woman", Pic_Id = Resource.Drawable.Pic09}
            };
            return myData;
        }
    }

    public class MyData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Pic_Id { get; set; }
    }
}