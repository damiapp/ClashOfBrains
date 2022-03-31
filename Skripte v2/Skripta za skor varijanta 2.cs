

        public void AddScore(Score score)
        {
            Database db = DatabaseFactory.CreateDatabase("cnGrammit");

            score.ID = Convert.ToInt32(db.ExecuteScalar("dbo.usp_Z_Score_addScore", new Guid(score.UserId), this.ID, score.RatingRaw, score.Text, score.IsPro));

            List<Score> list = (score.IsPro) ? this.Pros : this.Cons;

            //remove placeholder
            if (list.Count == 1 && list[0].RatingRaw == 0)
                list.RemoveAt(0);

            list.Add(score);
        }