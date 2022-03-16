using System;
using Todo.Domain.Commands;
using Xunit;

namespace Todo.Domain.Tests.CommandTests;

public class CreateTodoCommandTests
{
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("","", DateTime.Now);
    private readonly CreateTodoCommand _validCommand = 
    new CreateTodoCommand(
        "Titulo da tarefa",
        "davy carvalho", 
        DateTime.Now);

    public CreateTodoCommandTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }

    [Fact]
    public void Dado_um_comando_invalido()
    {
        Assert.Equal(false, _invalidCommand.Valid);
    }

    [Fact]
    public void Dado_um_comando_valido()
    {
        Assert.Equal(true, _validCommand.Valid);
    }
}
