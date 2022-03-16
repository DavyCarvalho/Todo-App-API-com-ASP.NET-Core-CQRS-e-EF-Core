using System;
using Todo.Domain.Entities;
using Xunit;

namespace Todo.Domain.Tests.EntityTests
{
    public class TodoItemTest
    {
        [Fact]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_estar_concluido()
        {
            var todo = new TodoItem("Titulo", "Davy", DateTime.Now);
            Assert.Equal(false, todo.Done);
        }
    }
}
