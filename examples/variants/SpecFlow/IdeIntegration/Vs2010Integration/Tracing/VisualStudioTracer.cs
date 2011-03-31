﻿using System;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Windows.Threading;
using TechTalk.SpecFlow.Vs2010Integration.Tracing.OutputWindow;

namespace TechTalk.SpecFlow.Vs2010Integration.Tracing
{
    [Export(typeof(IVisualStudioTracer))]
    internal class VisualStudioTracer : IVisualStudioTracer
    {
        private const string TracingCategory = "Tracing";

        private IOutputWindowService outputWindowService;
        private Dispatcher dispatcher;

        [Import]
        public IOutputWindowService OutputWindowService
        {
            get { return outputWindowService; }
            set
            {
                outputWindowService = value;
                if (value != null)
                    ShowInitTrace();
            }
        }

        private readonly bool traceEnabled;
        private readonly bool traceAll;
        private readonly string[] traceCategories;

        public VisualStudioTracer(IOutputWindowService outputWindowService) : this()
        {
            this.OutputWindowService = outputWindowService;
        }

        public VisualStudioTracer()
        {
            var traceSettings = Environment.GetEnvironmentVariable("SPECFLOW_TRACE");
            traceEnabled = !string.IsNullOrWhiteSpace(traceSettings);
            if (traceEnabled)
            {
                traceAll =
                    string.Equals(traceSettings, "all", StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(traceSettings, "true", StringComparison.InvariantCultureIgnoreCase);

                if (!traceAll)
                {
                    Debug.Assert(traceSettings != null);
                    traceCategories = traceSettings.Split(',').Select(cat => cat.Trim().ToLower()).ToArray();
                }
            }
        }

        private void ShowInitTrace()
        {
            if (!traceEnabled)
                return;

            dispatcher = Dispatcher.CurrentDispatcher;

            if (traceAll)
                Trace("Tracing enabled for all categories", TracingCategory);
            else
                Trace("Tracing enabled for categories: " + string.Join(", ", traceCategories), TracingCategory);
        }

        public void Trace(string message, string category)
        {
            if (!IsEnabled(category))
                return;

            dispatcher.BeginInvoke(new Action(() =>
                {
                    var outputWindow =
                        OutputWindowService.TryGetPane(OutputWindowDefinitions.SpecFlowOutputWindowName);
                    if (outputWindow != null)
                        outputWindow.WriteLine(string.Format("{0}: {1}", category, message));
                }), DispatcherPriority.ContextIdle);
        }

        public bool IsEnabled(string category)
        {
            if (!traceEnabled)
                return false;

            if (!traceAll && !traceCategories.Contains(category.ToLower()) && !category.Equals(TracingCategory, StringComparison.InvariantCultureIgnoreCase))
                return false;

            return true;
        }

        [Conditional("DEBUG")]
        static public void Assert(bool condition, string message)
        {
            if (!condition)
                throw new InvalidOperationException("Assertion fauiled: " + message);
        }
    }

}
