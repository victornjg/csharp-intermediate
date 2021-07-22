using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        private DateTime StartTime;
        private DateTime EndTime;
        private bool IsRunning;

        public void Start()
        {
            if (this.IsRunning)
                throw new InvalidOperationException("This stopwatch was already started and cannot be started again.");
            this.StartTime = DateTime.Now;
            this.IsRunning = true;
        }

        public void Stop()
        {
            if (!this.IsRunning)
                throw new InvalidOperationException("This stopwatch wasn't started in order to be stopped.");
            this.EndTime = DateTime.Now;
            this.IsRunning = false;
        }

        public TimeSpan CalculateDuration()
        {
            return this.EndTime - this.StartTime;
        }
    }
}
