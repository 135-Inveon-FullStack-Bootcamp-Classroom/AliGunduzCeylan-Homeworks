import { CircularProgress, Grid } from "@mui/material";

import Layout from "./Layout";
import MemCard from "./MemeCard";

import { useMemesContext } from "../Contexts/MemesContext";
import { Link } from "react-router-dom";

const CapsList = () => {
  const { memes } = useMemesContext();

  if (!memes)
    return (
      <Layout>
        <CircularProgress />
      </Layout>
    );

  return (
    <Layout>
      <Grid
        container
        direction="row"
        justifyContent="center"
        alignItems="center"
      >
        {memes.map((meme) => (
          <Grid item md={4}>
            <Link to={`/single-caps/${meme.id}`}>
              <MemCard img={meme.url} title={meme.name} />
            </Link>
          </Grid>
        ))}
      </Grid>
    </Layout>
  );
};

export default CapsList;
