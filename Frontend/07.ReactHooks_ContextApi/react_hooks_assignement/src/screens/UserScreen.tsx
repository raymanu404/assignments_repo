import React, { useState, useRef, useContext, useEffect } from 'react';
import '../css/userScreen.css';
import { useAxios } from '../components/useAxios';
import { ColorContext } from '../App';

interface IUserData {
  FirstName: string;
  LastName: string;
  Age: number;
  Gender: string;
}

function UserScreen() {
  const inputRef = useRef<HTMLInputElement>(null);
  const inputAgeRef = useRef<HTMLInputElement>(null);
  const inputLastNameRef = useRef<HTMLInputElement>(null);
  const colors = useContext(ColorContext);

  const [userData, setUserData] = useState<IUserData>({
    FirstName: 'Ovidiu',
    LastName: 'Vasi',
    Age: 22,
    Gender: 'Male',
  });

  const clickHandler = () => {
    inputRef.current?.focus();
  };
  const clickLastNameHandler = () => {
    inputLastNameRef.current?.focus();
  };
  const changeFirstNameHandler = (e: React.ChangeEvent<HTMLInputElement>) => {
    let value: string = e.target.value;
    if (value !== '') {
      setUserData({
        ...userData,
        FirstName: value,
      });
    }
  };

  const changeLastNameHandler = (e: React.ChangeEvent<HTMLInputElement>) => {
    let value: string = e.target.value;
    if (value !== '') {
      setUserData({
        ...userData,
        LastName: value,
      });
    }
  };
  const changeAgeHandler = (e: React.ChangeEvent<HTMLInputElement>) => {
    let value: number = Number(e.target.value);
    if (value > 0) {
      setUserData({
        ...userData,
        Age: value,
      });
    }
  };

  const changeGenderHandler = (e: React.ChangeEvent<HTMLInputElement>) => {
    let value: string = e.target.value;
    if (value === 'Male' || value === 'Female') {
      setUserData({
        ...userData,
        Gender: value,
      });
    }
  };
  const res = useAxios(
    'https://datausa.io/api/data?drilldowns=Nation&measures=Population',
    {}
  );

  if (!res) {
    return (
      <div>
        <h1>Loading...</h1>
      </div>
    );
  }

  return (
    <div
      className="userContainer"
      style={{
        backgroundColor: colors.purple,
      }}
    >
      <div className="infoContainer">
        <label>FirstName:</label>
        <input
          ref={inputRef}
          value={userData.FirstName}
          type="text"
          onChange={(e: React.ChangeEvent<HTMLInputElement>) =>
            changeFirstNameHandler(e)
          }
        />
        <button onClick={clickHandler} className="buttonClick">
          Focus on input
        </button>
      </div>
      <div className="infoContainer">
        <label>LastName:</label>
        <input
          ref={inputLastNameRef}
          value={userData.LastName}
          type="text"
          onChange={(e: React.ChangeEvent<HTMLInputElement>) =>
            changeLastNameHandler(e)
          }
        />
        <button onClick={clickLastNameHandler} className="buttonClick">
          Focus on input
        </button>
      </div>
      <div className="infoContainer" id="ageContainer">
        <label>Age:</label>
        <input
          ref={inputAgeRef}
          value={userData.Age}
          type="number"
          onChange={(e: React.ChangeEvent<HTMLInputElement>) =>
            changeAgeHandler(e)
          }
          step={1}
          max={100}
          min={1}
        />
      </div>
      <div className="infoContainer" id="genderContainer">
        <label>Gender:</label>
        <div
          onChange={(e: React.ChangeEvent<HTMLInputElement>) =>
            changeGenderHandler(e)
          }
        >
          <input
            type="radio"
            value="Male"
            checked={userData.Gender === 'Male'}
            readOnly={true}
          />
          <label>Male</label>
          <input
            type="radio"
            value="Female"
            checked={userData.Gender === 'Female'}
            readOnly={true}
          />
          <label>Female</label>
        </div>
      </div>

      <h2
        style={{
          display: 'flex',
          justifyContent: 'center',
        }}
      >
        Hello{' '}
        {userData.Gender === 'Male'
          ? 'Mr.'
          : userData.Gender === 'Female'
          ? 'Ms.'
          : ''}
        {userData.FirstName} {userData.LastName} with {userData.Age} years{' '}
      </h2>
    </div>
  );
}
export default UserScreen;
