import { useEffect, useState } from 'react';
import axios from 'axios';
import { json } from 'node:stream/consumers';

export const useAxios = (url: string, options?: Object) => {
  const [response, setResponse] = useState<Object>({});

  useEffect(() => {
    setResponse(getDataAxios(url, options));
  }, []);

  return response;
};

const getDataAxios = async (url: string, options?: Object) => {
  const res = await axios.get(url, options);
  console.log(res.data['data']);
  const result = JSON.stringify(res.data['data']);
  return result;
};
