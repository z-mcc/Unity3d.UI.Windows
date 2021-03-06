//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the UI.Windows Flow Addon.
//     Do not change anything in this file because it was auto-generated by FlowCompiler.
//     See more: https://github.com/chromealex/Unity3d.UI.Windows
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI.Windows;
using UnityEngine.UI.Windows.Types;

namespace ExampleProject.UI.Menu.MainMenu {

	public class MainMenuScreenBase : LayoutWindowType {
		
		public class FlowFunctionLoaderRoutes : WindowRoutes {
			
			public FlowFunctionLoaderRoutes(IFunctionIteration window, int index) : base(window, index) {}
					
			/// <summary>
			/// Flows to the GameplayView.
			/// Use this method to play transition effect on B window only.
			/// If you call Hide() on A window - it will hide with standard behaviour.
			/// Full Name: ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen
			/// </summary>
			/// <returns>GameplayView</returns>
			public virtual ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen FlowGameplayView() {
				
				return this.INTERNAL_FlowGameplayView(hide: false);
				
			}
			
			/// <summary>
			/// Flows to the GameplayView.
			/// Hides current window.
			/// Use this method to play transition effect on both windows (A and B).
			/// Full Name: ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen
			/// </summary>
			/// <returns>GameplayView</returns>
			public virtual ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen FlowHideGameplayView() {
				
				return this.INTERNAL_FlowGameplayView(hide: true);
				
			}
			
			private ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen INTERNAL_FlowGameplayView(bool hide, System.Action<ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen> onParametersPassCall = null) {
				
				return WindowSystemFlow.DoFlow<ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen>(this, 39, 25, hide, onParametersPassCall);
				
			}
			
		}
		
		/// <summary>
		/// Call the Function Loader.
		/// Use this method to play transition effect on B window only.
		/// If you call Hide() on A window - it will hide with standard behaviour.
		/// Function: Loading
		/// </summary>
		/// <returns>Function root window</returns>
		public virtual ExampleProject.UI.Loader.Loading.LoadingScreen FlowFunctionLoader(UnityEngine.Events.UnityAction<FlowFunctionLoaderRoutes> onFunctionEnds) {
			
			return this.INTERNAL_FlowFunctionLoader(false, onFunctionEnds);
			
		}
		
		/// <summary>
		/// Call the Function Loader.
		/// Hides current window.
		/// Use this method to play transition effect on both windows (A and B).
		/// Function: Loading
		/// </summary>
		/// <returns>Function root window</returns>
		public virtual ExampleProject.UI.Loader.Loading.LoadingScreen FlowHideFunctionLoader(UnityEngine.Events.UnityAction<FlowFunctionLoaderRoutes> onFunctionEnds) {
			
			return this.INTERNAL_FlowFunctionLoader(true, onFunctionEnds);
			
		}
		
		private ExampleProject.UI.Loader.Loading.LoadingScreen INTERNAL_FlowFunctionLoader(bool hide, UnityEngine.Events.UnityAction<FlowFunctionLoaderRoutes> onFunctionEnds, System.Action<ExampleProject.UI.Loader.Loading.LoadingScreen> onParametersPassCall = null) {
			
			var item = UnityEngine.UI.Windows.Plugins.Flow.FlowSystem.GetAttachItem(43, 39);
			var newWindow = WindowSystem.Show<ExampleProject.UI.Loader.Loading.LoadingScreen>(
				(w) => WindowSystem.RegisterFunctionCallback(w, (index) => onFunctionEnds(new FlowFunctionLoaderRoutes(this, index))),
				item,
				onParametersPassCall
			);
			
			WindowSystemFlow.OnDoTransition(item.index, 43, 39, hide);
			
			if (hide == true) this.Hide(item);
			
			return newWindow;
			
		}
		
	}

}