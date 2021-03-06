using System;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;
using Xunit;

namespace Todo.Domain.Tests.HandlerTests
{
    public class CreateTodoHandlerTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo da tarefa", "davy carvalho", DateTime.Now);
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        public CreateTodoHandlerTests()
        {
        }

        [Fact]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            var result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.Equal(false, result.Success);
        }

        [Fact]
        public void Dado_um_comando_valido_deve_criar_nova_tarefa()
        {
            var result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.Equal(true, result.Success);
        }
    }
}
