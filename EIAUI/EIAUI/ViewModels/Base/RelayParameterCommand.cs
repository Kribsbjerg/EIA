﻿using System;
using System.Windows.Input;

namespace EIAUI
{
    class RelayParameterCommand : ICommand
    {
        #region Private Members

        /// <summary>
        /// The action to run
        /// </summary>
        private Action<object> _action;

        #endregion

        #region Public events

        /// <summary>
        /// The event that fires when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructors

        /// <summary>
        /// Defualt constructor
        /// </summary>
        /// <param name="action"></param>
        public RelayParameterCommand(Action<object> action)
        {
            _action = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// A relay comman can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Excutes the command Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter) => _action(parameter);

        #endregion
    }
}
