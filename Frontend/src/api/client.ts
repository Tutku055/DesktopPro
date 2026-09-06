import axios, { AxiosError } from 'axios';
import { ENV } from '@/config/env';
import type { ProblemDetails, ValidationProblemDetails } from '@/types/api.types';

export const apiClient = axios.create({
    baseURL: ENV.API_BASE_URL,
    headers: {
        'Content-Type': 'application/json',
    },
    timeout: 10000,
}); 

//Response Interceptor: Central RFC 7807 Error Handling
apiClient.interceptors.response.use(
    (response) => response,
    (error: AxiosError<ProblemDetails | ValidationProblemDetails>) => {
        if(error.response){
            const {status,data}= error.response;

            switch (status){
                case 400:
                    console.warn('[Bad Request]',data);
                    break;
                case 401:
                    console.warn('[Unauthorized]',data);
                    break;
                case 403:
                    console.warn('[Forbidden]',data);
                    break;
                case 404:
                    console.warn('[Not Found]',data);
                    break;
                case 500:
                    console.warn('[Internal Server Error]',data);
                    break;
                default:
                    console.warn('[Unexpected Error]',data);
            }
        }
        else if (error.request){
            console.error('[Network Error ]: Backend service is unreachable');
        }

        return Promise.reject(error);
    }
);  