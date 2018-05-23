// Decompiled with JetBrains decompiler
// Type: ClassLibrary1.Person
// Assembly: ClassLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C5FD17A0-8A42-472F-8B33-304CA742C358
// Assembly location: C:\Users\isisi\OneDrive\Documentos\Universidad\Programacion orientada a objetos\Laboratorio 10\Lab 10\ClassLibrary1.dll

using System;

namespace ClassLibrary1
{
  internal class Person
  {
    private string first_name;
    private string last_name;
    private DateTime birth_date;
    private Address address;
    private string alma_mater;
    private string professional_degree;
    private string rut;
    private Person parent1;
    private Person parent2;

    public Person(string first_name, string last_name, DateTime birth_date, Address address, string rut, Person parent1, Person parent2)
    {
      this.first_name = first_name;
      this.last_name = last_name;
      this.birth_date = birth_date;
      this.address = address;
      this.rut = rut;
      this.parent1 = parent1;
      this.parent2 = parent2;
    }

    public string First_name
    {
      get
      {
        return this.first_name;
      }
    }

    public string Last_name
    {
      get
      {
        return this.last_name;
      }
    }

    public DateTime Birth_date
    {
      get
      {
        return this.birth_date;
      }
    }

    public string Alma_mater
    {
      get
      {
        return this.alma_mater;
      }
    }

    public string Professional_degree
    {
      get
      {
        return this.professional_degree;
      }
    }

    public string Rut
    {
      get
      {
        return this.rut;
      }
    }

    internal Address Address
    {
      get
      {
        return this.address;
      }
    }

    internal Person Parent1
    {
      get
      {
        return this.parent1;
      }
    }

    internal Person Parent2
    {
      get
      {
        return this.parent2;
      }
    }

    public void changeFirstName(string new_name)
    {
      this.first_name = new_name;
    }

    public void changeLastName(string new_last_name)
    {
      this.last_name = new_last_name;
    }

    public void giveUpOwnershipToThirdParty(Person person)
    {
      this.address.changeOwner(person);
      this.address = (Address) null;
    }

    public bool getAdopted(Person parent)
    {
      if (this.parent1 != null || this.parent2 != null)
        return false;
      this.parent1 = parent;
      return true;
    }

    public bool getAdopted(Person parent1, Person parent2)
    {
      if (parent1 != null || parent2 != null)
        return false;
      this.parent1 = parent1;
      this.parent2 = parent2;
      return true;
    }

    public void getAbandoned()
    {
      this.parent1 = (Person) null;
      this.parent2 = (Person) null;
    }

    public bool setEducation(string alma_mater, string professional_degree)
    {
      if ((DateTime.Now - this.birth_date).TotalDays <= 8350.0)
        return false;
      this.alma_mater = alma_mater;
      this.professional_degree = professional_degree;
      return true;
    }
  }
}
