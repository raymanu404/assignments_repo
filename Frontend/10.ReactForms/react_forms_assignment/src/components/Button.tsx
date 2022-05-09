import React from 'react';
import '../css/registerForm.css';

function Button(props: any) {
  return (
    <button
      id="openRegisterFormButton"
      onClick={props.onClickHandler}
      type={props?.Type}
    >
      {props.textButton}
    </button>
  );
}

export default Button;
