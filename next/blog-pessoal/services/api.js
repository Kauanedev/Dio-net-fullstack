import axios from 'axios';

export const api = axios.create({
    baseURL: 'https://boxltbpjgpuklzxdnehq.supabase.co',
    headers: {
        apikey: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImJveGx0YnBqZ3B1a2x6eGRuZWhxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzEwMTAzMzEsImV4cCI6MjA0NjU4NjMzMX0.8fi3lPffnD3mMwez_hO5Wq6jgRcL3LxUeGaB6qA87n8",
        authorization: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImJveGx0YnBqZ3B1a2x6eGRuZWhxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzEwMTAzMzEsImV4cCI6MjA0NjU4NjMzMX0.8fi3lPffnD3mMwez_hO5Wq6jgRcL3LxUeGaB6qA87n8"
    }
})