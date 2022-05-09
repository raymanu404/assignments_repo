import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import React, { useState, useRef, useEffect } from 'react';
import { Controller, useForm } from 'react-hook-form';
import '../css/registerForm.css';
import { faCircleRight, faCircleLeft } from '@fortawesome/free-solid-svg-icons';
import Button from '../components/Button';
import { joiResolver } from '@hookform/resolvers/joi';
import * as Joi from 'joi';
import { valid } from 'joi';

interface FormValues {
  fullname: string;
  age: number;
  gender: string;
  phonenumber: string;
  email: string;
  username: string;
  password: string;
  r_password: string;
}

const schema = Joi.object({
  fullname: Joi.string()
    .pattern(/^[A-Za-z\s]{1,}[\.]{0,1}[A-Za-z\s]{0,}$/)
    .max(40)
    .required(),

  age: Joi.number().min(1).max(100).positive().required(),

  gender: Joi.string().required(),

  phonenumber: Joi.string()
    .pattern(/^[+]*[(]{0,1}[0-9]{1,3}[)]{0,1}[-\s\./0-9]*$/)
    .max(14)
    .required(),

  email: Joi.string()
    .pattern(/^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/)
    .required(),

  username: Joi.string()
    .pattern(/^[a-z0-9_.]+$/)
    .required(),

  password: Joi.string()
    .pattern(new RegExp('^[a-zA-Z0-9]+$'))
    .max(30)
    .required(),

  r_password: Joi.ref('password'),
})
  .required()
  .with('password', 'r_password');

export default function RegisterForm() {
  const {
    register,
    handleSubmit,
    setValue,
    getValues,
    setFocus,
    control,
    formState: { errors },
  } = useForm<FormValues>({ resolver: joiResolver(schema) });

  const [page, setPage] = useState<number>(0);
  const [firstPageClicked, setFirstPageClicked] = useState<Boolean>(false);

  const onSubmit = handleSubmit((data) => console.log(data));

  const checkUserInputSubmitHandler = () => {
    setFirstPageClicked(true);
    if (
      !errors.email?.message &&
      !errors.username?.message &&
      !errors.password?.message &&
      !errors.r_password?.message
    ) {
      setPage(3);
      onSubmit();
    }
  };

  const onChangePageHandler = () => {
    setFirstPageClicked(true);
    if (
      !errors.fullname?.message &&
      !errors.age?.message &&
      !errors.gender?.message &&
      !errors.phonenumber?.message
    ) {
      setFirstPageClicked(false);
      setPage(2);
    }
  };

  const onChangeFirstPageHandler = () => {
    setPage(1);
  };
  const openRegisterForm = () => {
    onSubmit();
    setPage(1);
  };

  console.log(errors);
  const FirstPartRegisterForm = () => {
    return (
      <div>
        <form className="registerForm">
          <div className="inputContainer">
            <label>FullName:</label>
            <input
              {...register('fullname')}
              type={'text'}
              placeholder="ex: Ion Popescu"
              // onChange={(e) => {
              //   const value: string = e.target.value;
              //   // setValue('fullname', value);
              //   setFocus('fullname');
              //   // setFocus('fullname');
              //   // if (
              //   //   value.length > 0 ||
              //   //   value.match(/^[A-Za-z\s]{1,}[\.]{0,1}[A-Za-z\s]{0,}$/)
              //   // ) {
              //   // } else {
              //   //   setError('fullname', { message: 'fullname is r' });
              //   // }
              // }}
            />

            {errors.fullname?.message && firstPageClicked ? (
              <label className="errorLabel">{errors.fullname.message}</label>
            ) : null}
          </div>
          <div className="inputContainer">
            <label>Age:</label>
            <input
              {...register('age')}
              type={'number'}
              // onChange={(e) => {
              //   setFocus('age');
              // }}
              placeholder="20"
              step={1}
              min={1}
              max={100}
            />
            {errors.age?.message && firstPageClicked ? (
              <label className="errorLabel">{errors.age.message}</label>
            ) : null}
          </div>
          <div className="inputContainer">
            <label>Gender:</label>
            <div>
              <div style={{ display: 'flex', paddingLeft: 10 }}>
                <input type="radio" value="Male" {...register('gender')} />
                <label>Male</label>
              </div>
              <div style={{ display: 'flex', paddingLeft: 10 }}>
                <input type="radio" value="Female" {...register('gender')} />
                <label>Female</label>
              </div>
              <div style={{ display: 'flex', paddingLeft: 10 }}>
                <input type="radio" value="Other" {...register('gender')} />
                <label>Other</label>
              </div>
            </div>
            {errors.gender?.message && firstPageClicked ? (
              <label className="errorLabel">{errors.gender.message}</label>
            ) : null}
          </div>
          <div className="inputContainer">
            <label>PhoneNumber:</label>
            <input
              {...register('phonenumber')}
              type={'tel'}
              // onChange={(e) => {
              //   setValue('phonenumber', e.target.value);
              // }}
              placeholder="+40 720 897 909"
            />
            {errors.phonenumber?.message && firstPageClicked ? (
              <label className="errorLabel">{errors.phonenumber.message}</label>
            ) : null}
          </div>
        </form>
        <FontAwesomeIcon
          icon={faCircleRight}
          style={{ cursor: 'pointer', color: '#CCF3EE', paddingBottom: 10 }}
          onClick={() => onChangePageHandler()}
        />
      </div>
    );
  };

  const SecondPageRegisterForm = () => {
    return (
      <div>
        <form onSubmit={onSubmit} className="registerForm">
          <div className="inputContainer">
            <label>Email:</label>
            <input
              {...register('email')}
              type={'email'}
              placeholder="test@email.com"
            />
            {errors.email?.message && firstPageClicked ? (
              <label className="errorLabel">{errors.email.message}</label>
            ) : null}
          </div>
          <div className="inputContainer">
            <label>Username:</label>
            <input
              {...register('username')}
              type={'text'}
              placeholder="goofie_89"
            />
            {errors.username?.message && firstPageClicked ? (
              <label className="errorLabel">{errors.username.message}</label>
            ) : null}
          </div>
          <div className="inputContainer">
            <label>Password:</label>
            <input
              {...register('password')}
              type={'password'}
              placeholder="Password"
            />
            {errors.password?.message && firstPageClicked ? (
              <label className="errorLabel">{errors.password.message}</label>
            ) : null}
          </div>
          <div className="inputContainer">
            <label>Confirm Password:</label>
            <input
              {...register('r_password')}
              type={'password'}
              placeholder="Confirm password"
            />
            {errors.r_password?.message && firstPageClicked ? (
              <label className="errorLabel">{errors.r_password.message}</label>
            ) : null}
          </div>
          <Button
            textButton="Submit"
            onClickHandler={checkUserInputSubmitHandler}
            Type="submit"
          />
        </form>
        <FontAwesomeIcon
          icon={faCircleLeft}
          style={{
            cursor: 'pointer',
            color: '#CCF3EE',
            paddingBottom: 10,
          }}
          onClick={() => onChangeFirstPageHandler()}
        />
      </div>
    );
  };
  const DefaultMessageRegisterForm = () => {
    return (
      <div className="defaultContainer">
        <h2>Register now in our application</h2>
        <Button textButton="Register now!" onClickHandler={openRegisterForm} />
      </div>
    );
  };

  const RegisterSucceeded = () => {
    return (
      <div className="appContainer">
        <h3>Welcome in app </h3>
        <label>Fullname: {getValues('fullname')}</label>
        <label>Age: {getValues('age')}</label>
        <label>Email: {getValues('email')}</label>
        <label>Phonenumber: {getValues('phonenumber')}</label>
        <label>Gender: {getValues('gender')}</label>
        <label>Username: {getValues('username')}</label>
      </div>
    );
  };
  const FormStart = () => {
    return (
      <>
        <h3>Register form</h3>
        {page === 1 ? (
          <FirstPartRegisterForm />
        ) : page === 2 ? (
          <SecondPageRegisterForm />
        ) : (
          <DefaultMessageRegisterForm />
        )}
      </>
    );
  };
  return (
    <div className="formContainer">
      {page === 3 ? <RegisterSucceeded /> : <FormStart />}
    </div>
  );
}
