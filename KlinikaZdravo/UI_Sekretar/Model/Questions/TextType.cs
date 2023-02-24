// File:    Article.cs
// Created: Tuesday, June 2, 2020 7:18:18 PM
// Purpose: Definition of Class Article

using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Questions
{
    internal class TextType : IIdentifiable<long>
    {
        public long Id { get; set; }
        public TypeText TypeText;

        public TextType() { }
        public TextType(long id) 
        {
            Id = id;
        }
        public TextType(long id, TypeText typeText) 
        {
            Id = id;
            TypeText = typeText;
        }

        
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}