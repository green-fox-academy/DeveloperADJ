class ApprenticesController < ApplicationController

	before_action :authenticate_admin!

	def create
		@apprentice = Apprentice.new(apprentice_params)

		@apprentice.save
		redirect_to @apprentice
	end

	def edit
  		@apprentice = Apprentice.find(params[:id])
	end

	def update
	  @apprentice = Apprentice.find(params[:id])
	 
	  if @apprentice.update(apprentice_params)
	    redirect_to @apprentice
	  else
	    render 'edit'
	  end
	end

	def show
		@apprentice = Apprentice.find(params[:id])
				redirect_to :admin
	end

	def destroy
		@apprentice = Apprentice.find(params[:id])
		@apprentice.destroy
		redirect_to :admin
	end

	private

	def apprentice_params
		params.require(:apprentice).permit(:name, :team_id)
	end

end
