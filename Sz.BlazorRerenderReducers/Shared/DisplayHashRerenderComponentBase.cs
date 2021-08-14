﻿using System;
using Microsoft.AspNetCore.Components;

namespace Sz.BlazorRerenderReducers
{
    /// <summary>
    /// Components that inherit have their re-render controlled by a "display hash", or a string representation
    /// of all info that could affect their display state.  Useful for reducing the frequency of component re-renders to
    /// a minimum.
    ///
    /// Do not inherit this on components that are already fast to rerender and thus won't benefit much.
    /// Do not inherit this on components that take only primitives as Parameters (Blazor will optimize these).
    /// Do not inherit this on components that have a very complicated display state, as it will be too hard to maintain.
    ///   (consider refactoring such components into several subcomponents)
    /// </summary>
    /// <remarks>Also includes optional render profiling code (so you can see how often a re-render happens)</remarks>
    public abstract class DisplayHashRerenderComponentBase : ComponentBase
    {

        /// <summary>
        /// Returns a string that, accross successive calls, would indicate when to re-render: no change would indicate
        /// a re-render is not needed, and a change would indicate a render is needed.
        /// When it returns null, should also trigger a re-render regardless of whether it is a change.
        /// </summary>
        /// <remarks>Override this method to return a unique value for each unique display state of the component--i.e. 
        /// a string that is different when any displayable state changes,
        /// and the same value when no visible change happens.
        ///
        /// Note that child components will not rerender if the current component doesn't rerender, as the current component will not
        /// set any parameters on its children unless it rerenders.</remarks>
        protected abstract string? GetDisplayHash();

        /// <summary>
        /// Returns a flag to indicate whether the component should render based on the current and previous values
        /// returned by GetDisplayHash.
        /// </summary>
        /// <remarks>Should not need to call explicitly nor override, but you can if needed.</remarks>
        protected override bool ShouldRender()
        {
            string? displayHash = GetDisplayHash();
            bool result = PreviousDisplayHash == null || PreviousDisplayHash != displayHash;
            PreviousDisplayHash = displayHash;
            return result;
        }
        private string? PreviousDisplayHash { get; set; } = null;


        #region rudimentary render profiling code

        private bool _outputRenderProfiling = false;

        /// <summary>
        /// Whether to output rudimentary render profiling info to console.
        /// </summary>
        protected bool OutputRenderProfiling
        {
            get => _outputRenderProfiling;
            set
            {
                _outputRenderProfiling = value;
                if (_outputRenderProfiling) RenderTimer = new();
            }
        }

        private ScopeTimer? RenderTimer { get; set; } = null;

        protected override void OnParametersSet()
        {
            if (!OutputRenderProfiling) return;
            Console.WriteLine($"{GetType().Name}");
            RenderTimer = new ScopeTimer($"Render time of {GetType().Name}");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (!OutputRenderProfiling) return;
            if (RenderTimer == null) Console.WriteLine($"Render done but no render timer in {GetType().Name}");
            else RenderTimer?.Lap();
        }

        #endregion
    }
}
