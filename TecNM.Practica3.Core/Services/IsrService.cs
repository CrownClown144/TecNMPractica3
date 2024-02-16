using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services.Interfaces;

namespace TecNM.Practica3.Core.Services;

public class IsrService: IIsrService {
    public Isr ProcessIsr(Person person)
    {
        var isr = new Isr();
        float baseC = 0;
        float result = 0;
        if (person.salary >= 0.01 && person.salary <= 7735.00)
        {
            baseC = person.salary - 0.01f;
            result = baseC * (01.92f / 100);
            isr.isrResult = result + 0.00f;
        }
        else if (person.salary >= 7735.01 && person.salary < 65651.07)
        {
            baseC = person.salary - 7735.01f;
            result = baseC * (06.40f / 100);
            isr.isrResult = result + 148.51f;
        }
        else if (person.salary >= 65651.08 && person.salary < 115375.90)
        {
            baseC = person.salary - 65651.08f;
            result = baseC * (10.88f / 100);
            isr.isrResult = result + 3855.14f;
        }
        else if (person.salary >= 115375.91 && person.salary < 134119.41)
        {
            baseC = person.salary - 115375.91f;
            result = baseC * (16.00f / 100);
            isr.isrResult = result + 9265.20f;
        }
        else if (person.salary >= 134119.42 && person.salary < 160577.65)
        {
            baseC = person.salary - 134119.42f;
            result = baseC * (17.92f / 100);
            isr.isrResult = result + 12264.16f;
        }
        else if (person.salary >= 160577.66 && person.salary < 323862.00)
        {
            baseC = person.salary - 160577.66f;
            result = baseC * (21.36f / 100);
            isr.isrResult = result + 17005.47f;
        }
        else if (person.salary >= 323862.01 && person.salary < 510451.00)
        {
            baseC = person.salary - 323862.01f;
            result = baseC * (23.52f / 100);
            isr.isrResult = result + 51883.01f;
        }
        else if (person.salary >= 510451.01 && person.salary < 974535.03)
        {
            baseC = person.salary - 510451.01f;
            result = baseC * (30.00f / 100);
            isr.isrResult = result + 95768.74f;
        }
        else if (person.salary >= 974535.04 && person.salary < 1299380.04)
        {
            baseC = person.salary - 974535.04f;
            result = baseC * (32.00f / 100);
            isr.isrResult = result + 234993.95f;
        }
        else if (person.salary >= 1299380.05 && person.salary < 3898140.12)
        {
            baseC = person.salary - 1299380.05f;
            result = baseC * (34.00f / 100);
            isr.isrResult = result + 338944.34f;
        }
        else if (person.salary >= 3898140.13)
        {
            baseC = person.salary - 3898140.13f;
            result = baseC * (35.00f / 100);
            isr.isrResult = result + 1222522.76f;
        }
        return isr;
    }
}