using System;
 
public interface IEvent : IDisposable {
	Type GetType { get; }
	bool IsRunning { get; }
	void Execute();
}
