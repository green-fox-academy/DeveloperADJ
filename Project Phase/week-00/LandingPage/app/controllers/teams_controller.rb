class TeamsController < ApplicationController
	
	before_action :authenticate_admin!

	def edit
  		@team = Team.find(params[:id])
	end

	def update
	  @team = Team.find(params[:id])
	 
	  if @team.update(team_params)
	    redirect_to @team
	  else
	    render 'edit'
	  end
	end

	def show
		@team = Team.find(params[:id])
				redirect_to :admin
	end

	def destroy
		@team = Team.find(params[:id])
		@team.destroy
		redirect_to :admin
	end

	private

	def team_params
		params.require(:team).permit(:name, :image)
	end

end
