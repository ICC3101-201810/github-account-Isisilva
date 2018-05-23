// Decompiled with JetBrains decompiler
// Type: ClassLibrary1.Car
// Assembly: ClassLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C5FD17A0-8A42-472F-8B33-304CA742C358
// Assembly location: C:\Users\isisi\OneDrive\Documentos\Universidad\Programacion orientada a objetos\Laboratorio 10\Lab 10\ClassLibrary1.dll

namespace ClassLibrary1
{
  internal class Car
  {
    private string brand;
    private string model;
    private int year;
    private Person owner;
    private string license_plate;
    private int seatbelts;
    private bool diesel;

    public Car(string brand, string model, int year, Person owner, string license_plate, int seatbelts, bool diesel)
    {
      this.brand = brand;
      this.model = model;
      this.year = year;
      this.owner = owner;
      this.license_plate = license_plate;
      this.seatbelts = seatbelts;
      this.diesel = diesel;
    }

    public string Brand
    {
      get
      {
        return this.brand;
      }
    }

    public string Model
    {
      get
      {
        return this.model;
      }
    }

    public int Year
    {
      get
      {
        return this.year;
      }
    }

    public string License_plate
    {
      get
      {
        return this.license_plate;
      }
    }

    public int Seatbelts
    {
      get
      {
        return this.seatbelts;
      }
    }

    public bool Diesel
    {
      get
      {
        return this.diesel;
      }
    }

    internal Person Owner
    {
      get
      {
        return this.owner;
      }
    }

    public void giveUpOwnershipToThirdParty(Person person)
    {
      this.owner = person;
    }
  }
}
