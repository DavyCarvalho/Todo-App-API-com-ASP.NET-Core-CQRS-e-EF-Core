using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Entities;
using Todo.Domain.Queries;
using Xunit;

namespace Todo.Domain.Tests.QueriesTests
{
    public class TodoQueryTest
    {
        private List<TodoItem> _items;

        public TodoQueryTest()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "usuarioA", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "usuarioA", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "andrebaltieri", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "usuarioA", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "andrebaltieri", DateTime.Now));
        }

        [Fact]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_andrebaltieri()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("andrebaltieri"));
            Assert.Equal(result.Count(), 2);
        }
    }
}
