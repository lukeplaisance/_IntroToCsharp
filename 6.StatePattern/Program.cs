using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StatePattern
{
    public interface IState
    {
       void OnEnter(IContext context);
        void UpdateState(IContext context);
        void OnExit(IContext context);
    }
    public interface IContext
    {
        IState CurrentState { get; set; }
        void UpdateContext();
        void ChangeState(IState state);
    }

    public class GameContext : IContext
    {
        public IState CurrentState { get; set; }

        public void ChangeState(IState state)
        {
            CurrentState.OnExit(this);
            CurrentState = state;
            state.UpdateState(this);
            state.OnEnter(this);
        }

        public void UpdateContext()
        {

        }
    }
    class GameStart : IState
    {
        public void OnEnter(IContext context)
        {
            Console.WriteLine("you've entered the GameStart state \n");
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("you've exited the GameStart state \n");
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(this);
            Console.WriteLine("updating state...\n");
        }
    }
    class GameRunning : IState
    {
        public void OnEnter(IContext context)
        {
            Console.WriteLine("you've entered the GameRunning state");
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("you've entered the GameRunning state");
        }

        public void UpdateState(IContext context)
        {
            throw new NotImplementedException();
        }
    }
    class GameEnd : IState
    {
        public void OnEnter(IContext context)
        {
            Console.WriteLine("you've entered the GameEnd state");
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("you've entered the GameEnd state");
        }

        public void UpdateState(IContext context)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
