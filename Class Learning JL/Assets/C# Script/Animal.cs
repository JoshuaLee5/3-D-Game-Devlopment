using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviours can be attached
public class OOP : MonoBehaviour
{
    //private void Start()
    //{
    //    Fish fish; //create an empty variable that stores fish data type
    //    //Instantate fish and store in variable
    //    fish = new Fish("Paratilapia polleni", 7);
    //    fish.PrintAnimal();
    //}

    private void Start()
    {
        Toyota t = new Toyota(50);
        t.Drive();
    }
}

//Abstract classes can only be inherited from, not instantiated
public abstract class Animal
{
    //encapsulated data can only be changed form within the class
    private string name;
    private int age;

    //class constructor for instantiating the object
    public Animal(string _name, int _age) //class constructor
    { 
        name = _name;
        age = _age;
    }

    public abstract void Eat();
    public abstract void Eat(string food);

    public virtual void PrintAnimal()
    {
        Debug.Log("Name: " + name);
        Debug.Log("Age: " + age);
    }

}

public class Fish : Animal
{
    public Fish(string _name, int _age) : base(_name, _age)
    {

    }
    
    public override void Eat()
    {
        Debug.Log("Fish is eating"); 
    }

    public override void Eat(string food)
    {
        Debug.Log("Fish has eaten " + food);
    }



    public override void PrintAnimal()
    {
       base.PrintAnimal();
        Debug.Log("This is the fish");
    }

}

public abstract class Vehicle
{
    private int speed;

    public Vehicle(int _speed)
    {
        speed = _speed;
    }

    public virtual void Drive() 
    {
        Debug.Log("Driving at " + speed + " KMH.");    
    }
}

public class Toyota : Vehicle
{
    public Toyota(int _speed) : base(_speed)
    { }

    public override void Drive()
    {
        base.Drive();
        Debug.Log("We be cruisin'.");
    }

}

public class BWM : Vehicle
{
    public BWM(int _speed) : base(_speed)
    { }

    public override void Drive()
    {
        base.Drive();
        Debug.Log("We be Drivin'.");
    }

}

public class Ford : Vehicle
{
    public Ford(int _speed) : base(_speed)
    { }

    public override void Drive()
    {
        base.Drive();
        Debug.Log("We be Dashin'.");
    }

}