﻿/**
 * MetroFramework - Modern UI for WinForms
 * 
 * The MIT License (MIT)
 * Copyright (c) 2011 Sven Walter, http://github.com/viperneo
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation the rights to use, copy, 
 * modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
 * and to permit persons to whom the Software is furnished to do so, subject to the 
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.Windows.Forms;

namespace MetroFramework.Animation
{
    public delegate void AnimationAction();
    public delegate bool AnimationFinishedEvaluator();

    public abstract class AnimationBase
    {
        public event EventHandler AnimationCompleted;
        private void OnAnimationCompleted()
        {
            if (AnimationCompleted != null)
                AnimationCompleted(this, EventArgs.Empty);
        }

        private DelayedCall timer;
        private Control targetControl;

        private AnimationAction actionHandler;
        private AnimationFinishedEvaluator evaluatorHandler;

        protected TransitionType transitionType;
        protected int counter;
        protected int startTime;
        protected int targetTime;

        public bool IsCompleted 
        {
            get
            {
                if (timer != null)
                    return !timer.IsWaiting;

                return true;
            }
        }
        public bool IsRunning 
        {
            get
            {
                if (timer != null)
                    return timer.IsWaiting;

                return false;
            }
        }

        public void Cancel()
        {
            if (IsRunning)
                timer.Cancel();
        }

        protected void Start(Control control, TransitionType transitionType, int duration, AnimationAction actionHandler)
        {
            Start(control, transitionType, duration, actionHandler, null);
        }
        protected void Start(Control control, TransitionType transitionType, int duration, AnimationAction actionHandler, AnimationFinishedEvaluator evaluatorHandler)
        {
            this.targetControl = control;
            this.transitionType = transitionType;
            this.actionHandler = actionHandler;
            this.evaluatorHandler = evaluatorHandler;

            this.counter = 0;
            this.startTime = 0;
            this.targetTime = duration;

            timer = DelayedCall.Start(DoAnimation, duration);
        }

        private void DoAnimation()
        {
            if (evaluatorHandler == null || evaluatorHandler.Invoke())
            {
                OnAnimationCompleted();
            }
            else
            {
                actionHandler.Invoke();
                counter++;

                timer.Start();
            }
        }

        protected int MakeTransition(float t, float b, float d, float c)
        {
            switch (transitionType)
            {
                case TransitionType.Linear:
                    // simple linear tweening - no easing 
                    return (int)(c * t / d + b);

                case TransitionType.EaseInQuad:
                    // quadratic (t^2) easing in - accelerating from zero velocity
                    return (int)(c * (t /= d) * t + b);

                case TransitionType.EaseOutQuad:
                    // quadratic (t^2) easing out - decelerating to zero velocity
                    return (int)(-c * (t = t / d) * (t - 2) + b);

                case TransitionType.EaseInOutQuad:
                    // quadratic easing in/out - acceleration until halfway, then deceleration
                    if ((t /= d / 2) < 1)
                    {
                        return (int)(c / 2 * t * t + b);
                    }
                    else
                    {
                        return (int)(-c / 2 * ((--t) * (t - 2) - 1) + b);
                    }

                case TransitionType.EaseInCubic:
                    // cubic easing in - accelerating from zero velocity
                    return (int)(c * (t /= d) * t * t + b);

                case TransitionType.EaseOutCubic:
                    // cubic easing in - accelerating from zero velocity
                    return (int)(c * ((t = t / d - 1) * t * t + 1) + b);

                case TransitionType.EaseInOutCubic:
                    // cubic easing in - accelerating from zero velocity
                    if ((t /= d / 2) < 1)
                    {
                        return (int)(c / 2 * t * t * t + b);
                    }
                    else
                    {
                        return (int)(c / 2 * ((t -= 2) * t * t + 2) + b);
                    }

                case TransitionType.EaseInQuart:
                    // quartic easing in - accelerating from zero velocity
                    return (int)(c * (t /= d) * t * t * t + b);

                case TransitionType.EaseInExpo:
                    // exponential (2^t) easing in - accelerating from zero velocity
                    if (t == 0)
                    {
                        return (int)b;
                    }
                    else
                    {
                        return (int)(c * Math.Pow(2, (10 * (t / d - 1))) + b);
                    }

                case TransitionType.EaseOutExpo:
                    // exponential (2^t) easing out - decelerating to zero velocity
                    if (t == d)
                    {
                        return (int)(b + c);
                    }
                    else
                    {
                        return (int)(c * (-Math.Pow(2, -10 * t / d) + 1) + b);
                    }

                default:
                    return 0;
            }
        }
    }
}
