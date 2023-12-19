using System;

// Абстрактна фабрика
public abstract class UniversityFactory
{
    public abstract Student CreateStudent();
    public abstract Professor CreateProfessor();
    public abstract Course CreateCourse();
}

// Конкретна фабрика для наукового університету
public class ScienceUniversityFactory : UniversityFactory
{
    public override Student CreateStudent()
    {
        return new ScienceStudent();
    }

    public override Professor CreateProfessor()
    {
        return new ScienceProfessor();
    }

    public override Course CreateCourse()
    {
        return new ScienceCourse();
    }
}

// Конкретна фабрика для гуманітарного університету
public class HumanitiesUniversityFactory : UniversityFactory
{
    public override Student CreateStudent()
    {
        return new HumanitiesStudent();
    }

    public override Professor CreateProfessor()
    {
        return new HumanitiesProfessor();
    }

    public override Course CreateCourse()
    {
        return new HumanitiesCourse();
    }
}

// Продукти для наукового університету
public class ScienceStudent : Student
{
}

public class ScienceProfessor : Professor
{
}

public class ScienceCourse : Course
{
}

// Продукти для гуманітарного університету
public class HumanitiesStudent : Student
{
}

public class HumanitiesProfessor : Professor
{
}

public class HumanitiesCourse : Course
{
}

// Базові класи для студентів професорів та іпзщих курсів
public abstract class Student
{
}

public abstract class Professor
{
}

public abstract class Course
{
}

// Використання фабрик
class Program
{
    static void Main()
    {
        UniversityFactory scienceFactory = new ScienceUniversityFactory();
        UniversityFactory humanitiesFactory = new HumanitiesUniversityFactory();

        Student scienceStudent = scienceFactory.CreateStudent();
        Professor scienceProfessor = scienceFactory.CreateProfessor();
        Course scienceCourse = scienceFactory.CreateCourse();

        Student humanitiesStudent = humanitiesFactory.CreateStudent();
        Professor humanitiesProfessor = humanitiesFactory.CreateProfessor();
        Course humanitiesCourse = humanitiesFactory.CreateCourse();



    }
}
