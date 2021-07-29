using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("This stopwatch was already started and cannot be started again.");
            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("This stopwatch wasn't started in order to be stopped.");
            _endTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan CalculateDuration()
        {
            return _endTime - _startTime;
        }
    }
}
