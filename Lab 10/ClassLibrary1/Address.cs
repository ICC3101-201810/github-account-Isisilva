// Decompiled with JetBrains decompiler
// Type: ClassLibrary1.Address
// Assembly: ClassLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C5FD17A0-8A42-472F-8B33-304CA742C358
// Assembly location: C:\Users\isisi\OneDrive\Documentos\Universidad\Programacion orientada a objetos\Laboratorio 10\Lab 10\ClassLibrary1.dll

namespace ClassLibrary1
{
  internal class Address
  {
    private string street;
    private int number;
    private string commune;
    private string city;
    private Person owner;
    private int year_of_contruction;
    private int bedrooms;
    private int bathrooms;
    private bool backyard;
    private bool pool;

    public Address(string street, int number, string commune, string city, Person owner, int year_of_contruction, int bedrooms, int bathrooms, bool backyard, bool pool)
    {
      this.street = street;
      this.number = number;
      this.commune = commune;
      this.city = city;
      this.owner = owner;
      this.year_of_contruction = year_of_contruction;
      this.bedrooms = bedrooms;
      this.bathrooms = bathrooms;
      this.backyard = backyard;
      this.pool = pool;
      if (backyard)
        return;
      pool = false;
    }

    public string Street
    {
      get
      {
        return this.street;
      }
    }

    public int Number
    {
      get
      {
        return this.number;
      }
    }

    public string Commune
    {
      get
      {
        return this.commune;
      }
    }

    public string City
    {
      get
      {
        return this.city;
      }
    }

    public int Year_of_contruction
    {
      get
      {
        return this.year_of_contruction;
      }
    }

    public int Bedrooms
    {
      get
      {
        return this.bedrooms;
      }
    }

    public int Bathrooms
    {
      get
      {
        return this.bathrooms;
      }
    }

    public bool Backyard
    {
      get
      {
        return this.backyard;
      }
    }

    internal Person Owner
    {
      get
      {
        return this.owner;
      }
    }

    public void changeOwner(Person person)
    {
      this.owner = person;
    }

    public bool addBeedrooms(int amount)
    {
      if (amount <= 0)
        return false;
      this.bedrooms += amount;
      return true;
    }

    public bool addBathrooms(int amount)
    {
      if (amount <= 0)
        return false;
      this.bathrooms += amount;
      return true;
    }
  }
}
