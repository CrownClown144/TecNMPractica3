using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services;
namespace TecNM.Practica3.Test;

public class IsrServiceShould
{
    [Fact]
    public void InTheFirstRangeWhenTheSalaryIs_3500_TheReturnIs_67_19981()
    {
        //arrange
        var expected = 67.19981f; 
        var person = new Person { salary = 3500.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheSecondRangeWhenTheSalaryIs_40500_TheReturnIs_2245_4695()
    {
        //arrange
        var expected = 2245.4695f; 
        var person = new Person { salary = 40500.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheThirdRangeWhenTheSalaryIs_99200_TheReturnIs_7505_2627()
    {
        //arrange
        var expected = 7505.2627f; 
        var person = new Person { salary = 99200.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheFourthRangeWhenTheSalaryIs_120000_50_TheReturnIs_10005_135()
    {
        //arrange
        var expected = 10005.135f; 
        var person = new Person { salary = 120000.50f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheFifthRangeWhenTheSalaryIs_150500_TheReturnIs_15199_56()
    {
        //arrange
        var expected = 15199.56f; 
        var person = new Person { salary = 150500.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheSixthRangeWhenTheSalaryIs_270500_TheReturnIs_40484_883()
    {
        //arrange
        var expected = 40484.883f; 
        var person = new Person { salary = 270500.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheSeventhRangeWhenTheSalaryIs_400050_TheReturnIs_69802_43()
    {
        //arrange
        var expected = 69802.43f; 
        var person = new Person { salary = 400050.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheEighthRangeWhenTheSalaryIs_850500_TheReturnIs_197783_44()
    {
        //arrange
        var expected = 197783.44f; 
        var person = new Person { salary = 850500.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheNinthRangeWhenTheSalaryIs_1100000_TheReturnIs_275142_72()
    {
        //arrange
        var expected = 67.19981f; 
        var person = new Person { salary = 3500.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheTenthRangeWhenTheSalaryIs_2500000_TheReturnIs_747155_1()
    {
        //arrange
        var expected = 747155.1f; 
        var person = new Person { salary = 2500000.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    [Fact]
    public void InTheEleventhRangeWhenTheSalaryIs_4000000_TheReturnIs_67_19981()
    {
        //arrange
        var expected = 1258173.6f; 
        var person = new Person { salary = 4000000.00f };
        var sut = new IsrService();
        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expected, result.isrResult);
    }
    
    
    
}