using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "App", "Plc", TypeComplexityEnum.Complex)]
	public partial class App : TcoCore.TcoContext, Vortex.Connector.IVortexObject, IApp, IShadowApp, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		TcoCore.TcoSequence _Sequence;
		public TcoCore.TcoSequence Sequence
		{
			get
			{
				return _Sequence;
			}
		}

		TcoCore.ITcoSequence IApp.Sequence
		{
			get
			{
				return Sequence;
			}
		}

		TcoCore.IShadowTcoSequence IShadowApp.Sequence
		{
			get
			{
				return Sequence;
			}
		}

		TcoCore.TcoSequencerObserver _SequenceObserver;
		public TcoCore.TcoSequencerObserver SequenceObserver
		{
			get
			{
				return _SequenceObserver;
			}
		}

		TcoCore.ITcoSequencerObserver IApp.SequenceObserver
		{
			get
			{
				return SequenceObserver;
			}
		}

		TcoCore.IShadowTcoSequencerObserver IShadowApp.SequenceObserver
		{
			get
			{
				return SequenceObserver;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Sequence.LazyOnlineToShadow();
			SequenceObserver.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Sequence.LazyShadowToOnline();
			SequenceObserver.LazyShadowToOnline();
		}

		public new PlainApp CreatePlainerType()
		{
			var cloned = new PlainApp();
			base.CreatePlainerType(cloned);
			cloned.Sequence = Sequence.CreatePlainerType();
			cloned.SequenceObserver = SequenceObserver.CreatePlainerType();
			return cloned;
		}

		protected PlainApp CreatePlainerType(PlainApp cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Sequence = Sequence.CreatePlainerType();
			cloned.SequenceObserver = SequenceObserver.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc.PlainApp source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainApp source)
		{
			source.CopyPlainToShadow(this);
		}

		public new void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public new void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainApp source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public App(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Sequence = new TcoCore.TcoSequence(this, "", "Sequence");
			_SequenceObserver = new TcoCore.TcoSequencerObserver(this, "", "SequenceObserver");
			PexConstructor(parent, readableTail, symbolTail);
		}

		public App(): base ()
		{
			PexPreConstructorParameterless();
			_Sequence = new TcoCore.TcoSequence();
			_SequenceObserver = new TcoCore.TcoSequencerObserver();
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainApp
	{
		public void CopyPlainToCyclic(Plc.App target)
		{
			base.CopyPlainToCyclic(target);
			Sequence.CopyPlainToCyclic(target.Sequence);
			SequenceObserver.CopyPlainToCyclic(target.SequenceObserver);
		}

		public void CopyPlainToCyclic(Plc.IApp target)
		{
			this.CopyPlainToCyclic((Plc.App)target);
		}

		public void CopyPlainToShadow(Plc.App target)
		{
			base.CopyPlainToShadow(target);
			Sequence.CopyPlainToShadow(target.Sequence);
			SequenceObserver.CopyPlainToShadow(target.SequenceObserver);
		}

		public void CopyPlainToShadow(Plc.IShadowApp target)
		{
			this.CopyPlainToShadow((Plc.App)target);
		}

		public void CopyCyclicToPlain(Plc.App source)
		{
			base.CopyCyclicToPlain(source);
			Sequence.CopyCyclicToPlain(source.Sequence);
			SequenceObserver.CopyCyclicToPlain(source.SequenceObserver);
		}

		public void CopyCyclicToPlain(Plc.IApp source)
		{
			this.CopyCyclicToPlain((Plc.App)source);
		}

		public void CopyShadowToPlain(Plc.App source)
		{
			base.CopyShadowToPlain(source);
			Sequence.CopyShadowToPlain(source.Sequence);
			SequenceObserver.CopyShadowToPlain(source.SequenceObserver);
		}

		public void CopyShadowToPlain(Plc.IShadowApp source)
		{
			this.CopyShadowToPlain((Plc.App)source);
		}
	}
}