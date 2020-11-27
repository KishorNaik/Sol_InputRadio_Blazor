using Microsoft.AspNetCore.Components.Forms;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class InputRadioButtonDemo
    {
        #region Constructor

        public InputRadioButtonDemo()
        {
            BlazorSurveyM = new BlazorSurvey();
        }

        #endregion Constructor

        #region Private Proeprty

        private BlazorSurvey BlazorSurveyM { get; set; }

        private List<(String id, string lable)> Opinions { get; set; }

        private bool IsLoad { get; set; }

        private String Message { get; set; }

        #endregion Private Proeprty

        #region Private Method

        private void GetOpinions()
        {
            var opinionsList = new List<(String id, string lable)>();
            opinionsList.Add(("terrible", "Terrible, I prefer vanilla JS."));
            opinionsList.Add(("ok", "It's ok I guess..."));
            opinionsList.Add(("awesome", "It's awesome!!!"));

            this.Opinions = opinionsList;
        }

        #endregion Private Method

        #region Ui Event Handler

        private void OnSubmit(EditContext editContext)
        {
            var flag = editContext?.Validate();
            if (flag == false) return;

            Message = "Thank you..";

            base.StateHasChanged();
        }

        #endregion Ui Event Handler

        #region Public & Protected Method

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                this.GetOpinions();
                IsLoad = true;

                base.StateHasChanged();
            }
        }

        #endregion Public & Protected Method
    }
}