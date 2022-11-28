import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
<<<<<<< HEAD
import { Usuarios } from "./components/Usuarios";
=======
import { Movimiento } from "./components/Movimiento";
>>>>>>> 5bcec3b (Movimiento)

const AppRoutes = [
  {
    index: true,
    element: <Movimiento />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  },
<<<<<<< HEAD
  {
    path: '/usuarios',
    element: <Usuarios />
  }
=======
  
>>>>>>> 5bcec3b (Movimiento)

];

export default AppRoutes;
