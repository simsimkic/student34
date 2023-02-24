// File:    Doctor.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Doctor

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class Doctor : Employee
    {  
        public List<Blog> Blogs;
      
        public Doctor() { }

        public Doctor(long id) 
        {
            Id = id;
            Blogs = new List<Blog>();
        }

        public Doctor(long id, List<Blog> blogs):base(id)
        {
            Blogs = blogs;
        }
      
    
      public void AddBlog(Blog newBlog)
      {
         if (newBlog == null)
            return;
         if (this.Blogs == null)
            this.Blogs = new System.Collections.Generic.List<Blog>();
         if (!this.Blogs.Contains(newBlog))
            this.Blogs.Add(newBlog);
      }
      
      /// <summary>
      /// Remove an existing Blog from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveBlog(Blog oldBlog)
      {
         if (oldBlog == null)
            return;
         if (this.Blogs != null)
            if (this.Blogs.Contains(oldBlog))
               this.Blogs.Remove(oldBlog);
      }
      
      /// <summary>
      /// Remove all instances of Blog from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllBlog()
      {
         if (Blogs != null)
                Blogs.Clear();
      }

    }
}