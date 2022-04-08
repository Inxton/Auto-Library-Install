using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainApp : TcoCore.PlainTcoContext
	{
		TcoCore.PlainTcoSequence _Sequence;
		public TcoCore.PlainTcoSequence Sequence
		{
			get
			{
				return _Sequence;
			}

			set
			{
				if (_Sequence != value)
				{
					_Sequence = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Sequence)));
				}
			}
		}

		TcoCore.PlainTcoSequencerObserver _SequenceObserver;
		public TcoCore.PlainTcoSequencerObserver SequenceObserver
		{
			get
			{
				return _SequenceObserver;
			}

			set
			{
				if (_SequenceObserver != value)
				{
					_SequenceObserver = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(SequenceObserver)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainApp()
		{
			_Sequence = new TcoCore.PlainTcoSequence();
			_SequenceObserver = new TcoCore.PlainTcoSequencerObserver();
		}
	}
}